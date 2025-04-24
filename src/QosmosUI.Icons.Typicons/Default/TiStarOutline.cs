// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiStarOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M16.855 20.966c-.224 0-.443-.05-.646-.146l-.104-.051-4.107-2.343-4.107 2.344-.106.053c-.488.228-1.085.174-1.521-.143-.469-.34-.701-.933-.586-1.509l.957-4.642-1.602-1.457-1.895-1.725-.078-.082c-.375-.396-.509-.97-.34-1.492.173-.524.62-.912 1.16-1.009l.102-.018 4.701-.521 1.946-4.31.06-.11c.262-.473.764-.771 1.309-.771.543 0 1.044.298 1.309.77l.06.112 1.948 4.312 4.701.521.104.017c.539.1.986.486 1.158 1.012.17.521.035 1.098-.34 1.494l-.078.078-3.498 3.184.957 4.632c.113.587-.118 1.178-.59 1.519-.252.182-.556.281-.874.281zm-8.149-6.564c-.039.182-.466 2.246-.845 4.082l3.643-2.077c.307-.175.684-.175.99 0l3.643 2.075-.849-4.104c-.071-.346.045-.705.308-.942l3.1-2.822-4.168-.461c-.351-.039-.654-.26-.801-.584l-1.728-3.821-1.726 3.821c-.146.322-.45.543-.801.584l-4.168.461 3.1 2.822c.272.246.384.617.302.966z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
