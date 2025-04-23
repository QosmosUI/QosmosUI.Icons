// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiV8 : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M6.832 6c0-.161.008-.322.023-.479.019-.207.07-.401.112-.599l-.694-1.377H0l2.182 3.818h1.527l2.097 3.98a6.534 6.534 0 0 1 1.727-2.745A5.123 5.123 0 0 1 6.832 6zM10.365 19.663L12 22.637l1.637-2.975c-.535.138-1.079.234-1.637.234s-1.101-.096-1.635-.233zM17.728 3.545l-.717 1.258c.056.238.112.476.134.726a5.148 5.148 0 0 1-.677 3.07 6.565 6.565 0 0 1 1.727 2.746l2.097-3.981h1.527L24 3.545h-6.272z M17.846 12.007a6 6 0 0 0-2.073-3.31A4.64 4.64 0 0 0 12 1.363 4.635 4.635 0 0 0 7.363 6a4.62 4.62 0 0 0 .865 2.697A5.988 5.988 0 0 0 6 13.363a6.01 6.01 0 0 0 3.814 5.592 6.02 6.02 0 0 0 4.375-.003 6.006 6.006 0 0 0 3.657-6.945zM12 4.227c1.129 0 2.046.917 2.046 2.045a2.046 2.046 0 0 1-4.092 0c0-1.128.918-2.045 2.046-2.045zm0 11.456a2.32 2.32 0 0 1 0-4.637c1.282 0 2.318 1.037 2.318 2.318S13.282 15.683 12 15.683z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
