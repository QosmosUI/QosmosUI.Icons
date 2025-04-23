// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaJarWheat : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 320 512";

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
		builder.AddAttribute(14, "d", "M32 32C32 14.3 46.3 0 64 0L256 0c17.7 0 32 14.3 32 32s-14.3 32-32 32L64 64C46.3 64 32 49.7 32 32zM0 160c0-35.3 28.7-64 64-64l192 0c35.3 0 64 28.7 64 64l0 288c0 35.3-28.7 64-64 64L64 512c-35.3 0-64-28.7-64-64L0 160zm112 0l-42.2 0c-3.2 0-5.8 2.6-5.8 5.8C64 198 90 224 122.2 224l21.8 0 32 0 21.8 0c32.1 0 58.2-26 58.2-58.2c0-3.2-2.6-5.8-5.8-5.8L208 160c-19.1 0-36.3 8.4-48 21.7c-11.7-13.3-28.9-21.7-48-21.7zm48 117.7c-11.7-13.3-28.9-21.7-48-21.7l-42.2 0c-3.2 0-5.8 2.6-5.8 5.8C64 294 90 320 122.2 320l21.8 0 32 0 21.8 0c32.1 0 58.2-26 58.2-58.2c0-3.2-2.6-5.8-5.8-5.8L208 256c-19.1 0-36.3 8.4-48 21.7zM112 352l-42.2 0c-3.2 0-5.8 2.6-5.8 5.8C64 390 90 416 122.2 416l21.8 0 0 32c0 8.8 7.2 16 16 16s16-7.2 16-16l0-32 21.8 0c32.1 0 58.2-26 58.2-58.2c0-3.2-2.6-5.8-5.8-5.8L208 352c-19.1 0-36.3 8.4-48 21.7c-11.7-13.3-28.9-21.7-48-21.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
