﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using MyAbpProjects.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProjects.Tasks
{
    public class Task : Entity, IHasCreationTime
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024;//64kb


        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public TaskState State { get; set; }
        public DateTime CreationTime { get; set; }

        public Task()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open; ;
        }

        public Task(string title, string description = null) : this()
        {
            Title = title;
            Description = description;
        }
    }

    public enum TaskState : byte
    {
        Open = 0,
        Completed = 1
    }
}
