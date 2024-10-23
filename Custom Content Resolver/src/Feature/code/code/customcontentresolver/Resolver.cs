using Newtonsoft.Json.Linq;
using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.LayoutService.Configuration;
using Sitecore.LayoutService.ItemRendering.ContentsResolvers;
using Sitecore.Mvc.Presentation;
using System;

namespace MySitecoreDiaries.Feature.ContextItemChildrenwithDataSouce.ContentResolvers.Custom
{
    public class ContextItemChildrenwithDataSouce : RenderingContentsResolver
    {
        public override object ResolveContents(Rendering rendering, IRenderingConfiguration renderingConfig)
        {
            JObject jobject = new JObject();
            JArray children = new JArray();
            try 
            {
                Item contextItem = this.GetContextItem(rendering, renderingConfig);
                string datasource = rendering.DataSource;
                if (datasource != null)
                {
                    Item datasourceItem = Context.Database.GetItem(datasource);
                    jobject["datasource"] = (JToken)this.ProcessItem(datasourceItem,rendering,renderingConfig);

                }
                if (contextItem.Children != null)
                {
                    foreach (Item item in contextItem.Children) 
                    { 
                        children.Add(this.ProcessItem(item,rendering,renderingConfig)); 
                    }
                    jobject["contextItemChildren"] = children;
                }
                return jobject;
                
            }
            catch (Exception ex) 
            {
                Log.Error($"error in {nameof(ContextItemChildrenwithDataSouce)}", ex, this);
            }

            return jobject;
        }

    }
}