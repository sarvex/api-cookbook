﻿/*
 * Copyright 2012-2013 inBloom, Inc. and its affiliates.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace InBloomClient.Entities
{
    public class CompetencyLevelDescriptorType
    {
        public string id { get; set; }

        /// <summary>
        /// A code or abbreviation that is used to refer to the competentcy level.
        /// </summary>
        [Range(1, 20)]
        [StringLength(20)]
        public string codeValue { get; set; }

        /// <summary>
        /// The description of the competency level.
        /// </summary>
        [Range(1, 1024)]
        [StringLength(1024)]
        public string description { get; set; }
    }
}
