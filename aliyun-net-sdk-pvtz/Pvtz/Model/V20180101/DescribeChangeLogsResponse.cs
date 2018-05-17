/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.pvtz.Model.V20180101
{
	public class DescribeChangeLogsResponse : AcsResponse
	{

		private string requestId;

		private int? totalItems;

		private int? totalPages;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeChangeLogs_ChangeLog> changeLogs;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalItems
		{
			get
			{
				return totalItems;
			}
			set	
			{
				totalItems = value;
			}
		}

		public int? TotalPages
		{
			get
			{
				return totalPages;
			}
			set	
			{
				totalPages = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeChangeLogs_ChangeLog> ChangeLogs
		{
			get
			{
				return changeLogs;
			}
			set	
			{
				changeLogs = value;
			}
		}

		public class DescribeChangeLogs_ChangeLog
		{

			private string operTime;

			private string operAction;

			private string operObject;

			private string entityId;

			private string entityName;

			private string operIp;

			private long? operTimestamp;

			private long? id;

			private string content;

			public string OperTime
			{
				get
				{
					return operTime;
				}
				set	
				{
					operTime = value;
				}
			}

			public string OperAction
			{
				get
				{
					return operAction;
				}
				set	
				{
					operAction = value;
				}
			}

			public string OperObject
			{
				get
				{
					return operObject;
				}
				set	
				{
					operObject = value;
				}
			}

			public string EntityId
			{
				get
				{
					return entityId;
				}
				set	
				{
					entityId = value;
				}
			}

			public string EntityName
			{
				get
				{
					return entityName;
				}
				set	
				{
					entityName = value;
				}
			}

			public string OperIp
			{
				get
				{
					return operIp;
				}
				set	
				{
					operIp = value;
				}
			}

			public long? OperTimestamp
			{
				get
				{
					return operTimestamp;
				}
				set	
				{
					operTimestamp = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}
		}
	}
}