﻿#region license
// Copyright 2016 Christoph Müller
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Tests.Test001_
{
	internal interface IOperation<out T, out U>
    {
	    T RunOnLinkedList(LinkedListExecutionState state);
	    U RunOnLfdll(LfdllExecutionState state);
    }

	internal abstract class Operation<T1, T2> : IOperation<T1, T2>
    {
	    public abstract T1 RunOnLinkedList(
            LinkedListExecutionState state);

	    public abstract T2 RunOnLfdll(
            LfdllExecutionState state);

	    public override string ToString()
        {
            return GetType().Name;
        }

	    public Operation(ObjectIdGenerator idGenerator)
        {
            IdGenerator = idGenerator;
        }

	    protected ObjectIdGenerator IdGenerator { get; private set; }
    }
}
