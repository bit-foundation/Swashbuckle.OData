using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;

namespace SwashbuckleODataSample.ApiControllers
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        [ActionOnDelete(EdmOnDeleteAction.Cascade)]
        public Client Client { get; set; }
    }
}