// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiStickyNote : ComponentBase
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
		builder.AddAttribute(14, "id", "Sticky_Note");
		builder.AddAttribute(15, "data-name", "Sticky Note");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M18.44,3.065H5.56a2.507,2.507,0,0,0-2.5,2.5v12.87a2.507,2.507,0,0,0,2.5,2.5h8.68A2.482,2.482,0,0,0,16,20.2l4.21-4.2a2.505,2.505,0,0,0,.73-1.77V5.565A2.5,2.5,0,0,0,18.44,3.065Zm-4.38,13.5v3.37H5.56a1.5,1.5,0,0,1-1.5-1.5V5.565a1.5,1.5,0,0,1,1.5-1.5H18.44a1.5,1.5,0,0,1,1.5,1.5v8.5H16.56A2.507,2.507,0,0,0,14.06,16.565Zm1,3.13v-3.13a1.5,1.5,0,0,1,1.5-1.5h3.13Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
