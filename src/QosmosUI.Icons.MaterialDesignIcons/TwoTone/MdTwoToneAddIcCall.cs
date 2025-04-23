// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneAddIcCall : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M19 17.41c-.88-.07-1.75-.22-2.6-.45l-1.2 1.2c1.21.41 2.48.67 3.8.76v-1.51zM6.54 4.95h-1.5c.09 1.32.34 2.58.75 3.79l1.2-1.21c-.24-.83-.39-1.7-.45-2.58z");
		builder.AddAttribute(18, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M20 20.95c.55 0 1-.45 1-1v-3.5c0-.55-.45-1-1-1-1.25 0-2.45-.2-3.57-.57-.1-.03-.21-.05-.31-.05-.26 0-.51.1-.71.29l-2.2 2.2c-2.83-1.44-5.15-3.75-6.59-6.59l2.2-2.21c.28-.26.36-.65.25-1C8.7 6.4 8.5 5.2 8.5 3.95c0-.55-.45-1-1-1H4c-.55 0-1 .45-1 1 0 9.39 7.61 17 17 17zm-3.6-3.99c.85.24 1.72.39 2.6.45v1.5c-1.32-.09-2.6-.35-3.8-.76l1.2-1.19zM5.03 4.95h1.5c.07.88.22 1.75.45 2.58l-1.2 1.21c-.4-1.21-.66-2.47-.75-3.79zm10.97 6h2v-3h3v-2h-3v-3h-2v3h-3v2h3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
