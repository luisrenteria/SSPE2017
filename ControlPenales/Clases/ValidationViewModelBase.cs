﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Globalization;

namespace ControlPenales
{
    public class ValidationViewModelBase : ViewModelBase, IDataErrorInfo
    {
        //private Dictionary<string, Binder> ruleMap = new Dictionary<string, Binder>();
        private Dictionary<string, List<Binder>> ruleMap = new Dictionary<string, List<Binder>>();

        public bool FindRule(string rule)
        {
            return ruleMap.ContainsKey(rule);
        }

        public void ClearRules()
        {
            ruleMap.Clear();
        }
        public void RemoveRule(string key)
        {
            if(ruleMap != null)
                ruleMap.Remove(key);
        }
        public int CountRules()
        {
            if (ruleMap != null)
                return ruleMap.Count;
            else
                return 0;
        }
        public void AddRule<T>(Expression<Func<T>> expression, Func<bool> ruleDelegate, string errorMessage)
        {
            var name = GetPropertyName(expression);
            //ruleMap.Add(name,new Binder(ruleDelegate, errorMessage));
            #region Cambio
            if (ruleMap.ContainsKey(name))
            {
                ruleMap[name].Add(new Binder(ruleDelegate, errorMessage));
            }
            else
            {
                var b = new List<Binder>();
                b.Add(new Binder(ruleDelegate, errorMessage));
                ruleMap.Add(name,b);
            }
            #endregion
        }

        protected override void Set<T>(Expression<Func<T>> path, T value, bool forceUpdate)
        {
            //ruleMap[GetPropertyName(path)].IsDirty = true;
            #region Cambio
            foreach (var r in ruleMap[GetPropertyName(path)])
            {
                r.IsDirty = true;
            }
            #endregion
            base.Set<T>(path, value, forceUpdate);
        }
        public bool HasErrors
        {
            get
            {
                //var values = ruleMap.Values.ToList();
                //values.ForEach(b => b.Update());

                #region Cambio
                var values = new List<Binder>();
                foreach (var b in ruleMap)
                {
                    foreach (var x in b.Value)
                        values.Add(x);
                }
                values.ForEach(b => b.Update());
                return values.Any(b => b.HasError);
                #endregion
                //return values.Any(b => b.HasError);
            }
        }
        public string Error
        {
            get
            {
                //var errors = from b in ruleMap.Values where b.HasError select b.Error;
                #region Cambio
                var values = new List<Binder>();
                foreach (var b in ruleMap)
                {
                    foreach (var x in b.Value)
                        values.Add(x);
                }
                var errors = from b in values where b.HasError select b.Error;
                return string.Join("\n", errors.ToList()[0]);
                #endregion
                //return string.Join("\n", errors.ToList()[0]);
            }
        }
        public string this[string columnName]
        {
            get
            {
                if (ruleMap.ContainsKey(columnName))
                {
                    #region Cambio
                    string mensaje = string.Empty;
                    foreach (var x in ruleMap[columnName])
                    {
                        x.Update();
                        if (!string.IsNullOrEmpty(x.Error))
                        if(!x.Error.StartsWith("Null"))
                        {
                            if(!string.IsNullOrEmpty(mensaje))
                                mensaje += Environment.NewLine;
                            mensaje += x.Error;
                        }
                    }
                    return mensaje;
                    #endregion
                    //ruleMap[columnName].Update();
                    //return ruleMap[columnName].Error;
                }
                return null;
            }
        }
        private class Binder
        {
            private readonly Func<bool> ruleDelegate;
            private readonly string message;
            internal Binder(Func<bool> ruleDelegate, string message)
            {
                this.ruleDelegate = ruleDelegate;
                this.message = message;

                IsDirty = true;
            }
            internal string Error { get; set; }
            internal bool HasError { get; set; }
            internal bool IsDirty { get; set; }
            internal void Update()
            {
                if (!IsDirty)
                    return;
                Error = null;
                HasError = false;
                try
                {
                    if (!ruleDelegate())
                    {
                        Error = message;
                        HasError = true;
                    }
                }
                catch (Exception e)
                {
                    Error = e.Message;
                    HasError = true;
                }
            }
        }
    }
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Debugging Aides

        /// <summary>
        /// Warns the developer if this object does not have
        /// a public property with the specified name. This 
        /// method does not exist in a Release build.
        /// </summary>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public virtual void VerifyPropertyName(string propertyName)
        {
            // Verify that the property name matches a real,  
            // public, instance property on this object.
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                string msg = "Invalid property name: " + propertyName;

                if (this.ThrowOnInvalidPropertyName)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }
        }

        /// <summary>
        /// Returns whether an exception is thrown, or if a Debug.Fail() is used
        /// when an invalid property name is passed to the VerifyPropertyName method.
        /// The default value is false, but subclasses used by unit tests might 
        /// override this property's getter to return true.
        /// </summary>
        protected virtual bool ThrowOnInvalidPropertyName { get; private set; }

        #endregion // Debugging Aides
        public event PropertyChangedEventHandler PropertyChanged;
        private Dictionary<string, object> propertyValueMap;
        protected ViewModelBase()
        {
            propertyValueMap = new Dictionary<string, object>();
        }
        private void InternalPropertyUpdate(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        /// <summary>
        /// Raises the PropertyChange event for the property specified
        /// </summary>
        /// <param name="propertyName">Property name to update. Is case-sensitive.</param>
        public virtual void RaisePropertyChanged(string propertyName)
        {
            this.VerifyPropertyName(propertyName);
            OnPropertyChanged(propertyName);
        }
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            if (!string.IsNullOrEmpty(propertyName))
                this.VerifyPropertyName(propertyName);

            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        protected virtual void OnPropertyValidateChanged(string propertyName = "")
        {
            StaticSourcesViewModel.SourceChanged = false;

            if (!string.IsNullOrEmpty(propertyName))
                this.VerifyPropertyName(propertyName);

            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
                Console.WriteLine(propertyName);
                StaticSourcesViewModel.SourceChanged = true;
            }
        }

        protected void OnPropertyChanged<T>(Expression<Func<T>> path)
        {
            string propertyName = GetPropertyName(path);
            InternalPropertyUpdate(propertyName);
        }
        protected T Get<T>(Expression<Func<T>> path)
        {
            return Get(path, default(T));
        }
        protected virtual T Get<T>(Expression<Func<T>> path, T defaultValue)
        {
            var propertyName = GetPropertyName(path);
            if (propertyValueMap.ContainsKey(propertyName))
            {
                return (T)propertyValueMap[propertyName];
            }
            else
            {
                propertyValueMap.Add(propertyName, defaultValue);
                return defaultValue;
            }
        }
        protected void Set<T>(Expression<Func<T>> path, T value)
        {
            Set(path, value, false);
        }
        protected virtual void Set<T>(Expression<Func<T>> path, T value, bool forceUpdate)
        {
            var oldValue = Get(path);
            var propertyName = GetPropertyName(path);

            if (!object.Equals(value, oldValue) || forceUpdate)
            {
                propertyValueMap[propertyName] = value;
                OnPropertyChanged(path);
            }
        }
        protected static string GetPropertyName<T>(Expression<Func<T>> expression)
        {
            if (expression == null)
                throw new ArgumentNullException("expression");

            Expression body = expression.Body;
            MemberExpression memberExpression = body as MemberExpression;
            if (memberExpression == null)
            {
                memberExpression = (MemberExpression)((UnaryExpression)body).Operand;
            }
            return memberExpression.Member.Name;
        }

    }
}