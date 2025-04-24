// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiKitchenTap : ComponentBase
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
		builder.AddAttribute(14, "d", "M305.3 67.89L73 150.4V199h46v-32.7l191.6-72.54-5.3-25.87zM369.5 169L119 252.5V217H73v222h61.1c-2.5-34.5 8.2-65.6 26.3-92.2 20-29.2 48.5-53.3 78.6-72.7 30-19.4 61.6-34 87.8-43.9 13.1-4.9 24.9-8.7 34.5-11.2 9.7-2.6 16.8-4 22.7-4h55v-46h-69.5zm46.5 85.2c-4 5.2-9.4 12.3-14.5 20.4-10.4 16.1-18.8 36.1-17.2 46.1 1.1 7.3 5.7 16.3 11.9 22.9 6.2 6.6 13.6 10.5 19.8 10.5 6.1 0 13.5-3.9 19.7-10.5 6.2-6.6 10.8-15.6 11.9-22.9 1.6-10-6.8-30-17.1-46.1-5.2-8.1-10.5-15.2-14.5-20.4zM41 457v30h138.5l-10-30H41z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
