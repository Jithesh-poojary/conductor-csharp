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
using System;

namespace Conductor.Client.Worker
{
    public class WorkflowTaskExecutorConfiguration
    {
        public int BatchSize { get; set; } = Math.Max(2, Environment.ProcessorCount * 2);
        public string Domain { get; set; } = null;
        public TimeSpan PollInterval { get; set; } = TimeSpan.FromMilliseconds(100);
        public string WorkerId { get; set; } = Environment.MachineName;
    }
}