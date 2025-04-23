// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiOpenPalm : ComponentBase
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
		builder.AddAttribute(14, "d", "M461.512 194.104L494 222.457S391.01 310.462 305.379 342.57c-8.514 3.191-45.39 8.99-69.714 8.99-9.03 0-16.327-.798-19.8-2.831-64.013-37.392-129.62-43.784-166.905-43.784-19.284.01-30.96 1.712-30.96 1.712V199.261s1.314.068 3.94.068c12.503 0 54.662-1.43 126.128-17.942a40.33 40.33 0 0 1 9.058-.973c24.324 0 57.707 16.804 73.1 18.818 29.49 3.892 112.272 6.207 112.272 6.207l22.621 33.996c-38.48 30.162-158.38 27.146-158.38 27.146s73.77 27.915 164.822-16.667c10.128-4.923 89.951-55.81 89.951-55.81zm-102.162-29.19l-16.074-4.378-57.406 27.185c5.556.273 18.487.516 23.741.74zm38.413-4.475l-61.794 29.277c4.262.136 14.75.438 14.75.438l6.617 8.757 54.652-28.557zm-17.815 66.98l74.423-44.621-18.487-11.462-70.531 37.382z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
