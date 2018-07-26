using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using OrchardCore.Html.Settings;

namespace Alternating
{

    public class Migrations : DataMigration
    {
        IContentDefinitionManager _contentDefinitionManager;

        public Migrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public int Create()
        {
            _contentDefinitionManager.AlterPartDefinition("AlternatingItem", part => part
                .WithField("AlternatingItemImage", cfg => cfg.OfType("MediaField").WithDisplayName("Main image")));

            //_contentDefinitionManager.AlterPartDefinition("AlternatingItemPart", part => part
            //    .WithField("AlternatingItemImage", cfg => cfg.OfType("MediaField").WithDisplayName("Main image")));

            _contentDefinitionManager.AlterTypeDefinition("AlternatingItem", menu => menu
                .Draftable()
                .Versionable()
                .Creatable()
                .WithPart("TitlePart", part => part.WithPosition("1"))
                .WithPart("AliasPart", part => part.WithPosition("2").WithSettings(new AliasPartSettings { Pattern = "{{ ContentItem | display_text | slugify }}" }))
                .WithPart("HtmlBodyPart",part=>part.WithPosition("3").WithSettings(new HtmlBodyPartSettings { Editor = "Wysiwig" }))
                .WithPart("AlternatingItem", part => part.WithPosition("4"))
            );
            _contentDefinitionManager.AlterTypeDefinition("AlternatingLiquorItemBag", menu => menu
              .Draftable()
              .Versionable()
              .Creatable()
              .Listable()
              .WithPart("TitlePart", part => part.WithPosition("1"))
              .WithPart("AliasPart", part => part.WithPosition("2").WithSettings(new AliasPartSettings { Pattern = "{{ ContentItem | display_text | slugify }}" }))
              .WithPart("HtmlBodyPart", part => part.WithPosition("3"))
              .WithPart("BagPart", part => part.WithPosition("4").WithSetting("ContainedContentTypes", new string[] { "AlternatingItem" }))
              .Stereotype("Widget")
              );

            return 1;
        }
    }

    class AliasPartSettings
    {
        public string Pattern { get; set; }
    }
}
