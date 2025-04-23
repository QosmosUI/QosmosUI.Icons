// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaHanukiah : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 640 512";

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
		builder.AddAttribute(14, "d", "M314.2 3.3C309.1 12.1 296 36.6 296 56c0 13.3 10.7 24 24 24s24-10.7 24-24c0-19.4-13.1-43.9-18.2-52.7C324.6 1.2 322.4 0 320 0s-4.6 1.2-5.8 3.3zm-288 48C21.1 60.1 8 84.6 8 104c0 13.3 10.7 24 24 24s24-10.7 24-24c0-19.4-13.1-43.9-18.2-52.7C36.6 49.2 34.4 48 32 48s-4.6 1.2-5.8 3.3zM88 104c0 13.3 10.7 24 24 24s24-10.7 24-24c0-19.4-13.1-43.9-18.2-52.7c-1.2-2.1-3.4-3.3-5.8-3.3s-4.6 1.2-5.8 3.3C101.1 60.1 88 84.6 88 104zm82.2-52.7C165.1 60.1 152 84.6 152 104c0 13.3 10.7 24 24 24s24-10.7 24-24c0-19.4-13.1-43.9-18.2-52.7c-1.2-2.1-3.4-3.3-5.8-3.3s-4.6 1.2-5.8 3.3zM216 104c0 13.3 10.7 24 24 24s24-10.7 24-24c0-19.4-13.1-43.9-18.2-52.7c-1.2-2.1-3.4-3.3-5.8-3.3s-4.6 1.2-5.8 3.3C229.1 60.1 216 84.6 216 104zM394.2 51.3C389.1 60.1 376 84.6 376 104c0 13.3 10.7 24 24 24s24-10.7 24-24c0-19.4-13.1-43.9-18.2-52.7c-1.2-2.1-3.4-3.3-5.8-3.3s-4.6 1.2-5.8 3.3zM440 104c0 13.3 10.7 24 24 24s24-10.7 24-24c0-19.4-13.1-43.9-18.2-52.7c-1.2-2.1-3.4-3.3-5.8-3.3s-4.6 1.2-5.8 3.3C453.1 60.1 440 84.6 440 104zm82.2-52.7C517.1 60.1 504 84.6 504 104c0 13.3 10.7 24 24 24s24-10.7 24-24c0-19.4-13.1-43.9-18.2-52.7c-1.2-2.1-3.4-3.3-5.8-3.3s-4.6 1.2-5.8 3.3zM584 104c0 13.3 10.7 24 24 24s24-10.7 24-24c0-19.4-13.1-43.9-18.2-52.7c-1.2-2.1-3.4-3.3-5.8-3.3s-4.6 1.2-5.8 3.3C597.1 60.1 584 84.6 584 104zM112 160c-8.8 0-16 7.2-16 16l0 96 0 16 32 0 0-16 0-96c0-8.8-7.2-16-16-16zm64 0c-8.8 0-16 7.2-16 16l0 96 0 16 32 0 0-16 0-96c0-8.8-7.2-16-16-16zm64 0c-8.8 0-16 7.2-16 16l0 96 0 16 32 0 0-16 0-96c0-8.8-7.2-16-16-16zm160 0c-8.8 0-16 7.2-16 16l0 96 0 16 32 0 0-16 0-96c0-8.8-7.2-16-16-16zm64 0c-8.8 0-16 7.2-16 16l0 96 0 16 32 0 0-16 0-96c0-8.8-7.2-16-16-16zm64 0c-8.8 0-16 7.2-16 16l0 96 0 16 32 0 0-16 0-96c0-8.8-7.2-16-16-16zM352 144c0-17.7-14.3-32-32-32s-32 14.3-32 32l0 176L96 320c-17.7 0-32-14.3-32-32l0-96c0-17.7-14.3-32-32-32s-32 14.3-32 32l0 96c0 53 43 96 96 96l192 0 0 64-128 0c-17.7 0-32 14.3-32 32s14.3 32 32 32l160 0 160 0c17.7 0 32-14.3 32-32s-14.3-32-32-32l-128 0 0-64 192 0c53 0 96-43 96-96l0-96c0-17.7-14.3-32-32-32s-32 14.3-32 32l0 96c0 17.7-14.3 32-32 32l-192 0 0-176z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
