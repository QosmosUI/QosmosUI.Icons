// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoBeer : ComponentBase
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
		builder.AddAttribute(14, "d", "M392,208H368v-5.74A63.93,63.93,0,0,0,321.65,96a111,111,0,0,0-27.59-47.29A108.62,108.62,0,0,0,216,16c-29.91,0-57.78,12.28-79,34.68a56,56,0,0,0-67.51,77.54A63.91,63.91,0,0,0,80,231.39V440a56.06,56.06,0,0,0,56,56H312a56.06,56.06,0,0,0,56-56v-8h24a72.08,72.08,0,0,0,72-72V280A72.08,72.08,0,0,0,392,208ZM176,416a16,16,0,0,1-32,0V256a16,16,0,0,1,32,0Zm64,0a16,16,0,0,1-32,0V256a16,16,0,0,1,32,0Zm64,0a16,16,0,0,1-32,0V256a16,16,0,0,1,32,0Zm16-224c-8.33,0-20.55-5.18-26.69-11.31A16,16,0,0,0,282,176H160a16,16,0,0,0-15,10.53C138.17,205.21,121.4,208,112,208a32,32,0,0,1,0-64c.09,0,9.12.34,16.4,5.8a16,16,0,1,0,19.2-25.6A63.69,63.69,0,0,0,112,112a63.55,63.55,0,0,0-14,1.57A24,24,0,0,1,120,80a23.78,23.78,0,0,1,19.38,9.84,51.35,51.35,0,0,1,4.71,7.9A16,16,0,0,0,176,96c0-6.77-3.61-15.17-10.76-25-.46-.63-1-1.25-1.45-1.86C178.39,55.44,196.64,48,216,48a76.86,76.86,0,0,1,55.23,23.18A80.2,80.2,0,0,1,292.61,142a16,16,0,0,0,12.73,18.71,16.29,16.29,0,0,0,3,.28,16,16,0,0,0,15.7-13A111.78,111.78,0,0,0,326,128.57,32,32,0,0,1,320,192ZM432,360a40,40,0,0,1-40,40H368V240h24a40,40,0,0,1,40,40Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
