using System.Runtime.Serialization;
using Umbraco.Cms.Core.PropertyEditors;

namespace uSync.Migrations.Migrators.FreshEgg.Models
{
	public class NestedContentWithPreviewConfiguration
	{
		
		[ConfigurationField("contentTypes", "Element Types", "views/propertyeditors/nestedcontent/nestedcontent.doctypepicker.html", Description = "Select the Element Types to use as models for the items.")]
		public NestedContentConfiguration.ContentType[]? ContentTypes { get; set; }

		[ConfigurationField("minItems", "Min Items", "number", Description = "Minimum number of items allowed.")]
		public int? MinItems { get; set; }

		[ConfigurationField("maxItems", "Max Items", "number", Description = "Maximum number of items allowed.")]
		public int? MaxItems { get; set; }

		[ConfigurationField("confirmDeletes", "Confirm Deletes", "boolean", Description = "Requires editor confirmation for delete actions.")]
		public string ConfirmDeletes { get; set; } = "0";


		[ConfigurationField("showIcons", "Show Icons", "boolean", Description = "Show the Element Type icons.")]
		public string ShowIcons { get; set; } = "0";


		[ConfigurationField("expandsOnLoad", "Expands on load", "boolean", Description = "A single item is automatically expanded")]
		public bool ExpandsOnLoad { get; set; } = true;


		[ConfigurationField("hideLabel", "Hide Label", "boolean", Description = "Hide the property label and let the item list span the full width of the editor window.")]
		public string HideLabel { get; set; }
	}
}
