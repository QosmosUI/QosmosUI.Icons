// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiPhone : ComponentBase
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
		builder.AddAttribute(14, "id", "Phone");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M14.436,20.938A11.384,11.384,0,0,1,4.572,3.9a1.668,1.668,0,0,1,1.241-.822,1.716,1.716,0,0,1,1.454.492l3.139,3.14a1.715,1.715,0,0,1,0,2.427l-.295.3a1.937,1.937,0,0,0,0,2.736l1.72,1.721a1.983,1.983,0,0,0,2.736,0l.29-.29a1.719,1.719,0,0,1,2.428,0l3.139,3.139a1.724,1.724,0,0,1,.492,1.455,1.669,1.669,0,0,1-.822,1.239A11.327,11.327,0,0,1,14.436,20.938ZM6.042,4.063a.793.793,0,0,0-.1.006.673.673,0,0,0-.5.331A10.375,10.375,0,0,0,19.594,18.567a.674.674,0,0,0,.331-.5.734.734,0,0,0-.208-.618l-3.139-3.139a.717.717,0,0,0-1.014,0l-.29.29a3.006,3.006,0,0,1-4.15,0L9.4,12.876a2.939,2.939,0,0,1,0-4.149l.3-.3a.717.717,0,0,0,0-1.014L6.56,4.277A.729.729,0,0,0,6.042,4.063Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
