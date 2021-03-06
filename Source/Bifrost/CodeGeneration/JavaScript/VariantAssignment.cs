﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace Bifrost.CodeGeneration.JavaScript
{
    /// <summary>
    /// Represents a variant assignment
    /// </summary>
    public class VariantAssignment : Assignment
    {
        /// <summary>
        /// Initializes a new instance of <see cref="VariantAssignment"/>
        /// </summary>
        /// <param name="name">Name of the variant</param>
        /// <param name="value"><see cref="ILanguageElement">value</see> to assign</param>
        public VariantAssignment(string name, ILanguageElement value = null)
            : base(name, value)
        {
        }

#pragma warning disable 1591
        public override void Write(ICodeWriter writer)
        {
            writer.WriteWithIndentation("var {0} = ", Name);
            if( Value != null ) Value.Write(writer);
            writer.Write(";");
            writer.Newline();
        }
#pragma warning restore 1591
    }
}
