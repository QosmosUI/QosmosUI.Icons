// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiHospital1 : ComponentBase
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
		builder.AddAttribute(14, "id", "Hospital_1");
		builder.AddAttribute(15, "data-name", "Hospital 1");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M18.435,7.5h-1.93V5.56a2.5,2.5,0,0,0-2.5-2.5h-4a2.5,2.5,0,0,0-2.5,2.5V7.5H5.565a2.5,2.5,0,0,0-2.5,2.5v9.44a1.511,1.511,0,0,0,1.5,1.5h14.87a1.5,1.5,0,0,0,1.5-1.5V10A2.5,2.5,0,0,0,18.435,7.5ZM7.505,19.94H4.565a.508.508,0,0,1-.5-.5V10a1.5,1.5,0,0,1,1.5-1.5h1.94Zm8,0h-1.5v-2.5a2.038,2.038,0,0,0-.59-1.42,2,2,0,0,0-3.41,1.42v2.5h-1.5V5.56a1.5,1.5,0,0,1,1.5-1.5h4a1.5,1.5,0,0,1,1.5,1.5Zm4.43-.5a.5.5,0,0,1-.5.5h-2.93V8.5h1.93a1.5,1.5,0,0,1,1.5,1.5Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M14.505,8.56a.5.5,0,0,1-.5.5h-1.5v1.5a.5.5,0,0,1-.5.5.5.5,0,0,1-.5-.5V9.06h-1.5a.5.5,0,0,1-.5-.5.5.5,0,0,1,.5-.5h1.5V6.56a.5.5,0,0,1,.5-.5.508.508,0,0,1,.5.5v1.5h1.5A.508.508,0,0,1,14.505,8.56Z");
		builder.CloseElement();
		builder.OpenElement(21, "g");
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M5.786,13.217a.5.5,0,0,1-.5-.5v-1.5a.5.5,0,0,1,1,0v1.5A.5.5,0,0,1,5.786,13.217Z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M5.786,17.717a.5.5,0,0,1-.5-.5v-1.5a.5.5,0,0,1,1,0v1.5A.5.5,0,0,1,5.786,17.717Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(26, "g");
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M18.221,13.217a.5.5,0,0,1-.5-.5v-1.5a.5.5,0,0,1,1,0v1.5A.5.5,0,0,1,18.221,13.217Z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M18.221,17.717a.5.5,0,0,1-.5-.5v-1.5a.5.5,0,0,1,1,0v1.5A.5.5,0,0,1,18.221,17.717Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
