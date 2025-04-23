// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCardJackDiamonds : ComponentBase
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
		builder.AddAttribute(14, "d", "M119.436 36c-16.126 0-29.2 17.237-29.2 38.5v363c0 21.263 13.074 38.5 29.2 38.5h275.298c16.126 0 29.198-17.237 29.198-38.5v-363c0-21.263-13.072-38.5-29.198-38.5H119.436zm26.884 3.717l47.393 58.27-47.393 58.286-47.375-58.287 47.375-58.27zm81.996 128.972h77.743v8.915h-11.055c-4.359 0-7.489.793-9.39 2.378-1.823 1.585-2.735 3.883-2.735 6.895v113.998c0 8.797-2.139 16.76-6.418 23.893-4.28 7.053-10.541 12.68-18.783 16.88-8.242 4.121-17.552 6.182-27.934 6.182-14.106 0-25.637-4.121-34.592-12.363-8.955-8.321-13.433-18.465-13.433-30.432 0-8.876 2.258-15.968 6.775-21.277 4.517-5.31 10.065-7.965 16.643-7.965 5.389 0 9.827 1.744 13.314 5.23 3.487 3.408 5.23 7.767 5.23 13.077 0 4.596-1.426 8.478-4.279 11.648-2.853 3.09-6.142 4.637-9.867 4.637-1.426 0-3.407-.397-5.943-1.19-2.14-.634-3.566-.95-4.28-.95-1.347 0-2.418.556-3.21 1.665-.872 1.11-1.307 2.773-1.307 4.992 0 5.944 2.972 11.372 8.916 16.286 6.023 4.834 13.392 7.251 22.11 7.251 9.905 0 17.711-3.409 23.417-10.224 5.706-6.895 8.559-16.482 8.559-28.766V186.877c0-3.09-1.07-5.389-3.21-6.895-2.06-1.585-5.626-2.378-10.698-2.378h-15.573v-8.915zm137.346 183.834l47.393 58.27-47.393 58.287-47.375-58.287 47.375-58.27z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
