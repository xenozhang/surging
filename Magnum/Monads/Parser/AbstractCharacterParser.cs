// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.Monads.Parser
{
    using System;

    public abstract class AbstractCharacterParser<TInput> :
        AbstractParser<TInput>
    {
        public abstract Parser<TInput, char> AnyChar { get; }

        public Parser<TInput, char> Char(char ch)
        {
            return from c in AnyChar where c == ch select c;
        }

        public Parser<TInput, char> Char(Predicate<char> pred)
        {
            return from c in AnyChar where pred(c) select c;
        }
    }
}