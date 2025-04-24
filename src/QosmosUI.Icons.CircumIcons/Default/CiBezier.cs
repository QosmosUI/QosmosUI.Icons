// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiBezier : ComponentBase
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
		builder.AddAttribute(14, "id", "Bezier");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M20.435,8.005a1.5,1.5,0,1,0-1.41-2H13.5v-.25a.749.749,0,0,0-.75-.75h-1.5a.755.755,0,0,0-.75.75v.25H4.975a1.5,1.5,0,0,0-2.91.5,1.5,1.5,0,0,0,2.91.5h3.79c-2.5,1.61-4.23,5-4.47,8.99h-.28a.749.749,0,0,0-.75.75v1.5a.749.749,0,0,0,.75.75h1.5a.755.755,0,0,0,.75-.75v-1.5a.755.755,0,0,0-.75-.75h-.21c.27-4.22,2.38-7.78,5.19-8.73a.747.747,0,0,0,.75.74h1.5a.741.741,0,0,0,.75-.74c2.81.95,4.93,4.51,5.21,8.73h-.22a.749.749,0,0,0-.75.75v1.5a.749.749,0,0,0,.75.75h1.5a.755.755,0,0,0,.75-.75v-1.5a.755.755,0,0,0-.75-.75H19.7c-.24-3.99-1.97-7.38-4.46-8.99h3.78A1.5,1.5,0,0,0,20.435,8.005Zm0-2a.508.508,0,0,1,.5.5.5.5,0,0,1-.5.5.5.5,0,0,1-.5-.5A.5.5,0,0,1,20.435,6.005Zm-16.87,1a.5.5,0,0,1-.5-.5.5.5,0,0,1,.5-.5.508.508,0,0,1,.5.5A.5.5,0,0,1,3.565,7.005ZM5.265,18h-1V17h1ZM12.5,7.005h-1v-1h1ZM18.735,17h1v1h-1Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
