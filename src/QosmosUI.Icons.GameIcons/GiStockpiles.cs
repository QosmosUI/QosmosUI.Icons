// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiStockpiles : ComponentBase
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
		builder.AddAttribute(14, "d", "M203.1 39.16l12.7 63.24c29.8-.6 29.9 42.8 39.6 75.3 15.2-37.4 11.6-150.5-52.3-138.54zm-17.4 4.73L17.5 102.4v19.9L189 60.41zm6.9 34.42l-24.7 8.91L197 100.5zm-49 17.65l-42.5 15.34 39.8 18 40.5-16.2zM76.76 120.1l-42.63 15.4 42.02 19.7 41.65-16.6zM17.5 147.5v31.2l35.89-14.4zm288.7 7l-24.6 10.6c16.8 7.7 34 17.8 48.8 13.4zm-97.4 3.3l-39.4 20.7c14.6 7.5 35.2 5.5 58.2-.4zm83.3 33.9c12.4 10.3 22.8 22.4 42.6 26-1.2-8.3.3-14.4-16.6-25.7zm-35.6.3c-32 0-186 185.8-234 297.8h273.7c15.1-35.2 43.1-78.7 70.2-114.8 10.7-14.1 21.1-27 30.6-37.7-57.9-78-121.3-145.3-140.5-145.3zm-50.5 2.2l-46.8 13c1.5 9.5 9.8 14.7 34.6 9.4zM438.4 326c-5.5-.1-10.7 4.9-19 13.5-11.1 11.5-24.7 27.8-38.5 46.4-24.5 32.6-49.9 72.3-64.7 103.9h178.3V385.2c-13.7-18.3-27.1-34.3-38-45.7-7.9-9.2-13.1-13.3-18.1-13.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
