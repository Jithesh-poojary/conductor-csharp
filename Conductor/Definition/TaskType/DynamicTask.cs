﻿/*
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
namespace Conductor.Definition.TaskType
{
    public class DynamicTask : Task
    {
        /// <summary>
        /// Gets or Sets DynamicTaskParam
        /// </summary>
        public string DynamicTaskParam { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicTask" /> class.
        /// </summary>
        /// <param name="dynamicTask"></param>
        /// <param name="taskRefName"></param>
        /// <param name="dynamicTaskParam"></param>
        public DynamicTask(string dynamicTask, string taskRefName, string dynamicTaskParam = "taskToExecute")
        : base(taskRefName, WorkflowTaskTypeEnum.DYNAMIC)
        {
            WithInput(dynamicTaskParam, dynamicTask);
            DynamicTaskParam = dynamicTaskParam;
        }
    }
}
