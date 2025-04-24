// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoBarbell : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M467,176a29.94,29.94,0,0,0-25.32,12.5,2,2,0,0,1-3.64-1.14V150.71c0-20.75-16.34-38.21-37.08-38.7A38,38,0,0,0,362,150v82a2,2,0,0,1-2,2H152a2,2,0,0,1-2-2V150.71c0-20.75-16.34-38.21-37.08-38.7A38,38,0,0,0,74,150v37.38a2,2,0,0,1-3.64,1.14A29.94,29.94,0,0,0,45,176c-16.3.51-29,14.31-29,30.62v98.72c0,16.31,12.74,30.11,29,30.62a29.94,29.94,0,0,0,25.32-12.5A2,2,0,0,1,74,324.62v36.67C74,382,90.34,399.5,111.08,400A38,38,0,0,0,150,362V280a2,2,0,0,1,2-2H360a2,2,0,0,1,2,2v81.29c0,20.75,16.34,38.21,37.08,38.7A38,38,0,0,0,438,362V324.62a2,2,0,0,1,3.64-1.14A29.94,29.94,0,0,0,467,336c16.3-.51,29-14.31,29-30.62V206.64C496,190.33,483.26,176.53,467,176Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
