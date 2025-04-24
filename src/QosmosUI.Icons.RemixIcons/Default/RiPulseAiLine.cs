// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiPulseAiLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M19.7134 8.12811L19.4668 8.69379C19.2864 9.10792 18.7136 9.10792 18.5331 8.69379L18.2866 8.12811C17.8471 7.11947 17.0555 6.31641 16.0677 5.87708L15.308 5.53922C14.8973 5.35653 14.8973 4.75881 15.308 4.57612L16.0252 4.25714C17.0384 3.80651 17.8442 2.97373 18.2761 1.93083L18.5293 1.31953C18.7058 0.893489 19.2942 0.893489 19.4706 1.31953L19.7238 1.93083C20.1558 2.97373 20.9616 3.80651 21.9748 4.25714L22.6919 4.57612C23.1027 4.75881 23.1027 5.35653 22.6919 5.53922L21.9323 5.87708C20.9445 6.31641 20.1529 7.11947 19.7134 8.12811ZM15 21.5386L9 7.53861L6.6594 13H1V11H5.3406L9 2.46143L15 16.4614L17.3406 11H23V13H18.6594L15 21.5386Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
