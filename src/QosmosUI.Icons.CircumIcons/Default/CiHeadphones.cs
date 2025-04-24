// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiHeadphones : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Headphones");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M12.23,3.065h-.46a8.211,8.211,0,0,0-8.2,8.2v6.25a3.385,3.385,0,0,0,.89,2.3,3.423,3.423,0,0,0,2.53,1.12h.53a1.225,1.225,0,0,0,1.22-1.22v-4.4A1.225,1.225,0,0,0,7.52,14.1H7.11a3.6,3.6,0,0,0-2.54,1.05v-3.88a7.208,7.208,0,0,1,7.2-7.2h.46a7.208,7.208,0,0,1,7.2,7.2v3.88a3.6,3.6,0,0,0-2.54-1.05h-.41a1.225,1.225,0,0,0-1.22,1.22v4.4a1.225,1.225,0,0,0,1.22,1.22h.53a3.423,3.423,0,0,0,2.53-1.12,3.385,3.385,0,0,0,.89-2.3v-6.25A8.211,8.211,0,0,0,12.23,3.065ZM4.58,17.275A2.511,2.511,0,0,1,7.11,15.1h.41a.222.222,0,0,1,.22.22v4.4a.222.222,0,0,1-.22.22H6.99a2.422,2.422,0,0,1-1.79-.79,2.322,2.322,0,0,1-.63-1.63A1.927,1.927,0,0,1,4.58,17.275Zm14.22,1.87a2.422,2.422,0,0,1-1.79.79h-.53a.222.222,0,0,1-.22-.22v-4.4a.222.222,0,0,1,.22-.22h.41a2.511,2.511,0,0,1,2.53,2.18,1.927,1.927,0,0,1,.01.24A2.322,2.322,0,0,1,18.8,19.145Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
