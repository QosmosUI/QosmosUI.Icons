// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiCloudRainbow : ComponentBase
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
		builder.AddAttribute(14, "id", "Cloud_Rainbow");
		builder.AddAttribute(15, "data-name", "Cloud Rainbow");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M21.8,6.648a8.6,8.6,0,0,0-12.78.82,6.329,6.329,0,0,0-.761-.05,6.212,6.212,0,0,0-6.2,6.2c0,.1.01.2.01.3a6.277,6.277,0,0,0,6.351,5.89h6.159a4.04,4.04,0,0,0,4.081-3.7,3.916,3.916,0,0,0-1.07-2.97,3.98,3.98,0,0,0-3.37-1.23,5.582,5.582,0,0,0-.38-.97,2.617,2.617,0,0,1,3.75-.08c.46.45,1.169-.26.71-.71a3.66,3.66,0,0,0-2.77-1.05,3.594,3.594,0,0,0-2.2.96,6.746,6.746,0,0,0-1.02-1.12,5.131,5.131,0,0,1,7.031.17c.46.45,1.169-.26.71-.71a6.134,6.134,0,0,0-4.51-1.77,5.982,5.982,0,0,0-4.031,1.73,5.632,5.632,0,0,0-1.409-.65,7.615,7.615,0,0,1,10.99-.35C21.546,7.808,22.255,7.1,21.8,6.648Zm-10.56,2.71a.712.712,0,0,0,.11.08,5.238,5.238,0,0,1,1.979,3.06.6.6,0,0,0,.271.37l.25.13.2-.05a2.977,2.977,0,0,1,3.61,3.1,3.037,3.037,0,0,1-3.081,2.76H8.416a5.27,5.27,0,0,1-5.351-4.94,5.2,5.2,0,0,1,8.171-4.51Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
