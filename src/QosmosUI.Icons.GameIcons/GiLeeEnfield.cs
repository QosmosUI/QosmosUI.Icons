// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiLeeEnfield : ComponentBase
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
		builder.AddAttribute(14, "d", "M465.659 42.63l-16.16 11.83 11.82 15.69-.272.181 6.32 8.559 22.551-17-8-10.68-6.26 4.71-10-13.29zm-29.09 21.48L269.108 183.86c0 .54-.06 1.03-.06 1.54l-2.16 22.78a16 16 0 0 1-6.52 11.46l-41.91 30.5a16 16 0 0 1-22.35-3.52l-4.95-6.8-29.79 21.48c-1.67 1.22-2.011 3.74-.811 6l2.09 3.951a4.9 4.9 0 0 1-.158 5.37l-48 58.71a1.77 1.77 0 0 1-.282.27l-90.699 70.42c-1.84 1.43-1.91 4.46-.15 6.76l40.82 54.179a5.69 5.69 0 0 0 4.41 2.41h.18a3.47 3.47 0 0 0 2.84-1.59l84.43-111.3a4.2 4.2 0 0 0 1.33-4.37s-3.04-16.07-2.32-17.07c0 0 28.7-38.39 28.95-38.58L454.788 88.7l-18.22-24.59zm-183.5 119.82l-54.14 39.39 10.118 13.91 41.91-30.5 2.112-22.8zm20.138 64.25l-38.629 29.6 7.49 15.37a5.14 5.14 0 0 0 4.73 2.87h.25a6 6 0 0 0 4.57-2.45l22.77-30.59a5.63 5.63 0 0 0 1-4.51l-2.18-10.29zm-59.44 45.6l-5.929 4.59a12.81 12.81 0 0 1-16.48 18.16l-2.26 3-2.26 3a20.27 20.27 0 0 0 30.08-14.81 20.1 20.1 0 0 0-3.15-13.94z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
