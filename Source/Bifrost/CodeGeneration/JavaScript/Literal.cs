﻿#region License
//
// Copyright (c) 2008-2015, Dolittle (http://www.dolittle.com)
//
// Licensed under the MIT License (http://opensource.org/licenses/MIT)
//
// You may not use this file except in compliance with the License.
// You may obtain a copy of the license at
//
//   http://github.com/dolittle/Bifrost/blob/master/MIT-LICENSE.txt
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion
namespace Bifrost.CodeGeneration.JavaScript
{
    /// <summary>
    /// Represents a literal
    /// </summary>
    public class Literal : LanguageElement
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Literal"/>
        /// </summary>
        /// <param name="content"><see cref="object"/> representing the content - the actual literal</param>
        public Literal(object content)
        {
            Content = content;
        }

        /// <summary>
        /// Gets or sets the representation of the literal
        /// </summary>
        public object Content { get; set; }

#pragma warning disable 1591
        public override void Write(ICodeWriter writer)
        {
            writer.Write(Content.ToString());
        }
#pragma warning restore 1591
    }
}
