﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources.ControlPenales.Login {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class LoginViewModel {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LoginViewModel() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.ControlPenales.Login.LoginViewModel", typeof(LoginViewModel).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Favor de capturar usuario y contraseña.
        /// </summary>
        public static string capturar_usuario_contrasena {
            get {
                return ResourceManager.GetString("capturar_usuario_contrasena", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ocurrió un error al iniciar login.
        /// </summary>
        public static string error_login {
            get {
                return ResourceManager.GetString("error_login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ocurrió un error al iniciar sesión.
        /// </summary>
        public static string error_sesion {
            get {
                return ResourceManager.GetString("error_sesion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Iniciando Sesión....
        /// </summary>
        public static string iniciando_sesion {
            get {
                return ResourceManager.GetString("iniciando_sesion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El password ha caducado.
        /// </summary>
        public static string password_caducado {
            get {
                return ResourceManager.GetString("password_caducado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Favor de seleccionar un centro.
        /// </summary>
        public static string seleccione_centro {
            get {
                return ResourceManager.GetString("seleccione_centro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El usuario o la contraseña son incorrectos.
        /// </summary>
        public static string usuario_contrasena_incorrecto {
            get {
                return ResourceManager.GetString("usuario_contrasena_incorrecto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El usuario no se encuentra activo.
        /// </summary>
        public static string usuario_inactivo {
            get {
                return ResourceManager.GetString("usuario_inactivo", resourceCulture);
            }
        }
    }
}