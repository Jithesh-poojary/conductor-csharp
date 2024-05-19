/*
 * Copyright 2024 Conductor Authors.
 * <p>
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * <p>
 * http://www.apache.org/licenses/LICENSE-2.0
 * <p>
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations under the License.
 */
using Conductor.Client.Models;
using System.Collections.Generic;

namespace Conductor.Definition.TaskType
{
    public class DoWhileTask : Task
    {
        public DoWhileTask(string taskReferenceName, string loopCondition, params WorkflowTask[] loopOver) : base(taskReferenceName, WorkflowTask.WorkflowTaskTypeEnum.DOWHILE)
        {
            LoopCondition = loopCondition;
            LoopOver = new List<WorkflowTask>(loopOver);
        }
    }

    public class LoopTask : DoWhileTask
    {
        public LoopTask(string taskReferenceName, int iterations, params WorkflowTask[] loopOver) :
            base(
                taskReferenceName: taskReferenceName,
                loopCondition: GetForLoopCondition(taskReferenceName, iterations),
                loopOver: loopOver
            )
        { }

        private static string GetForLoopCondition(string taskReferenceName, int iterations)
        {
            return "if ( $." + taskReferenceName + "['iteration'] < " + iterations.ToString() + " ) { true; } else { false; }";
        }
    }
}
