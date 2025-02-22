﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.DeleteLeaveRequest
{
    public class DeleteLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
