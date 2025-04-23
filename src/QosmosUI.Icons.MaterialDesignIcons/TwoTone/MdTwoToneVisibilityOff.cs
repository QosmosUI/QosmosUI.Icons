// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.TwoTone;

public class MdTwoToneVisibilityOff : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0zm0 0h24v24H0V0zm0 0h24v24H0V0zm0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M12 14c.04 0 .08-.01.12-.01l-2.61-2.61c0 .04-.01.08-.01.12 0 1.38 1.12 2.5 2.5 2.5zm1.01-4.79l1.28 1.28c-.26-.57-.71-1.03-1.28-1.28zm7.81 2.29C19.17 8.13 15.79 6 12 6c-.68 0-1.34.09-1.99.22l.92.92c.35-.09.7-.14 1.07-.14 2.48 0 4.5 2.02 4.5 4.5 0 .37-.06.72-.14 1.07l2.05 2.05c.98-.86 1.81-1.91 2.41-3.12zM12 17c.95 0 1.87-.13 2.75-.39l-.98-.98c-.54.24-1.14.37-1.77.37-2.48 0-4.5-2.02-4.5-4.5 0-.63.13-1.23.36-1.77L6.11 7.97c-1.22.91-2.23 2.1-2.93 3.52C4.83 14.86 8.21 17 12 17z");
		builder.AddAttribute(18, "opacity", ".3");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M12 6c3.79 0 7.17 2.13 8.82 5.5-.59 1.22-1.42 2.27-2.41 3.12l1.41 1.41c1.39-1.23 2.49-2.77 3.18-4.53C21.27 7.11 17 4 12 4c-1.27 0-2.49.2-3.64.57l1.65 1.65C10.66 6.09 11.32 6 12 6zm2.28 4.49l2.07 2.07c.08-.34.14-.7.14-1.07C16.5 9.01 14.48 7 12 7c-.37 0-.72.06-1.07.14L13 9.21c.58.25 1.03.71 1.28 1.28zM2.01 3.87l2.68 2.68C3.06 7.83 1.77 9.53 1 11.5 2.73 15.89 7 19 12 19c1.52 0 2.98-.29 4.32-.82l3.42 3.42 1.41-1.41L3.42 2.45 2.01 3.87zm7.5 7.5l2.61 2.61c-.04.01-.08.02-.12.02-1.38 0-2.5-1.12-2.5-2.5 0-.05.01-.08.01-.13zm-3.4-3.4l1.75 1.75c-.23.55-.36 1.15-.36 1.78 0 2.48 2.02 4.5 4.5 4.5.63 0 1.23-.13 1.77-.36l.98.98c-.88.24-1.8.38-2.75.38-3.79 0-7.17-2.13-8.82-5.5.7-1.43 1.72-2.61 2.93-3.53z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
