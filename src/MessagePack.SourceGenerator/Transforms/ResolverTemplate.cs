﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace MessagePack.SourceGenerator.Transforms
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ResolverTemplate : ResolverTemplateBase
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
 if (ResolverNamespace.Length > 0) { 
            this.Write("namespace ");
            this.Write(this.ToStringHelper.ToStringWithCulture(ResolverNamespace));
            this.Write("\r\n{\r\n");
 } 
            this.Write("\tusing MsgPack = global::MessagePack;\r\n\tusing Formatters = global::");
            this.Write(this.ToStringHelper.ToStringWithCulture(FormatterNamespace));
            this.Write(";\r\n\r\n\t/// <summary>A MessagePack resolver that uses generated formatters for type" +
                    "s in this assembly.</summary>\r\n\tpartial class ");
            this.Write(this.ToStringHelper.ToStringWithCulture(ResolverName));
            this.Write(" : MsgPack::IFormatterResolver\r\n\t{\r\n\t\t/// <summary>An instance of this resolver t" +
                    "hat only returns formatters specifically generated for types in this assembly.</" +
                    "summary>\r\n\t\tpublic static readonly MsgPack::IFormatterResolver Instance = new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(ResolverName));
            this.Write(@"();

		/// <summary>An instance of this resolver that returns standard AOT-compatible formatters as well as formatters specifically generated for types in this assembly.</summary>
		public static readonly MsgPack::IFormatterResolver InstanceWithStandardAotResolver = MsgPack::Resolvers.CompositeResolver.Create(Instance, MsgPack::Resolvers.StandardAotResolver.Instance);

		private ");
            this.Write(this.ToStringHelper.ToStringWithCulture(ResolverName));
            this.Write(@"()
		{
		}

		public MsgPack::Formatters.IMessagePackFormatter<T> GetFormatter<T>()
		{
			return FormatterCache<T>.Formatter;
		}

		private static class FormatterCache<T>
		{
			internal static readonly MsgPack::Formatters.IMessagePackFormatter<T> Formatter;

			static FormatterCache()
			{
				var f = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(ResolverName));
            this.Write("GetFormatterHelper.GetFormatter(typeof(T));\r\n\t\t\t\tif (f != null)\r\n\t\t\t\t{\r\n\t\t\t\t\tForm" +
                    "atter = (MsgPack::Formatters.IMessagePackFormatter<T>)f;\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t}\r\n\t}\r\n" +
                    "\r\n\tinternal static class ");
            this.Write(this.ToStringHelper.ToStringWithCulture(ResolverName));
            this.Write("GetFormatterHelper\r\n\t{\r\n\t\tprivate static readonly global::System.Collections.Gene" +
                    "ric.Dictionary<global::System.Type, int> lookup;\r\n\r\n\t\tstatic ");
            this.Write(this.ToStringHelper.ToStringWithCulture(ResolverName));
            this.Write("GetFormatterHelper()\r\n\t\t{\r\n\t\t\tlookup = new global::System.Collections.Generic.Dic" +
                    "tionary<global::System.Type, int>(");
            this.Write(this.ToStringHelper.ToStringWithCulture(RegisterInfos.Count));
            this.Write(")\r\n\t\t\t{\r\n");
 for(var i = 0; i < RegisterInfos.Count; i++) { var x = RegisterInfos[i]; 
            this.Write("\t\t\t\t{ typeof(");
            this.Write(this.ToStringHelper.ToStringWithCulture(x.FullName));
            this.Write("), ");
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            this.Write(" },\r\n");
 } 
            this.Write("\t\t\t};\r\n\t\t}\r\n\r\n\t\tinternal static object GetFormatter(global::System.Type t)\r\n\t\t{\r\n" +
                    "\t\t\tint key;\r\n\t\t\tif (!lookup.TryGetValue(t, out key))\r\n\t\t\t{\r\n\t\t\t\treturn null;\r\n\t\t" +
                    "\t}\r\n\r\n\t\t\tswitch (key)\r\n\t\t\t{\r\n");
 for(var i = 0; i < RegisterInfos.Count; i++) { var x = RegisterInfos[i]; 
            this.Write("\t\t\t\tcase ");
            this.Write(this.ToStringHelper.ToStringWithCulture(i));
            this.Write(": return new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(x.FormatterName));
            this.Write("();\r\n");
 } 
            this.Write("\t\t\t\tdefault: return null;\r\n\t\t\t}\r\n\t\t}\r\n\t}\r\n");
 if (ResolverNamespace.Length > 0) { 
            this.Write("}\r\n");
 } 
            return this.GenerationEnvironment.ToString();
        }
    }
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class ResolverTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        public System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
