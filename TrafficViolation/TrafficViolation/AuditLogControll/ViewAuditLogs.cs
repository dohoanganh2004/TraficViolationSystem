using System.Collections.ObjectModel;
using TrafficViolation.BLL.Services;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.AuditLogControll
{
    public class ViewAuditLogsViewModel : ViewModelBase
    {
        private readonly AuditLogService _auditLogService;
        public ObservableCollection<AuditLog> AuditLogs { get; set; }

        public ViewAuditLogsViewModel()
        {
            _auditLogService = new AuditLogService();
            AuditLogs = new ObservableCollection<AuditLog>(_auditLogService.GetAllAuditLogs());
        }
    }
}