// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoTonePanTool : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M19.5 5.65c-.28 0-.5.22-.5.5V12h-2V3.42c0-.28-.22-.5-.5-.5s-.5.22-.5.5V12h-2V2.51c0-.28-.22-.5-.5-.5s-.5.22-.5.5V12h-2V4.79c0-.28-.22-.5-.5-.5s-.5.23-.5.5v12.87l-5.35-2.83-.51.45 5.86 6.1c.38.39.9.62 1.44.62H18c1.1 0 2-.9 2-2V6.15c0-.28-.22-.5-.5-.5z");
		builder.AddAttribute(18, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M19.5 3.65c-.17 0-.34.02-.5.05v-.28c0-1.38-1.12-2.5-2.5-2.5-.33 0-.65.06-.94.18C15.11.44 14.35.01 13.5.01c-1.32 0-2.41 1.03-2.49 2.33-.16-.03-.33-.05-.51-.05-1.38 0-2.5 1.12-2.5 2.5v9.55l-2.41-1.28c-.73-.39-1.64-.28-2.26.27l-2.07 1.83 7.3 7.61c.75.78 1.8 1.23 2.89 1.23H18c2.21 0 4-1.79 4-4V6.15c0-1.38-1.12-2.5-2.5-2.5zM20 20c0 1.1-.9 2-2 2h-6.55c-.54 0-1.07-.22-1.44-.62l-5.86-6.11.51-.45L10 17.66V4.79c0-.28.22-.5.5-.5s.5.23.5.5V12h2V2.51c0-.28.22-.5.5-.5s.5.22.5.5V12h2V3.42c0-.28.22-.5.5-.5s.5.22.5.5V12h2V6.15c0-.28.22-.5.5-.5s.5.22.5.5V20z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
