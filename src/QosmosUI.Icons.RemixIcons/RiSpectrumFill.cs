// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiSpectrumFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M13.1997 2.00596C21.2413 2.09306 22.0006 3.25009 22.0006 12.0001L21.9948 13.1991C21.9077 21.2408 20.7506 22.0001 12.0006 22.0001L10.8016 21.9942C3.14288 21.9113 2.08947 20.8579 2.00651 13.1991L2.00098 11.6908L2.00651 10.801C2.09154 2.95085 3.19615 2.04037 11.3885 2.00146L13.1997 2.00596ZM8.25064 7.00009H7.66731C7.33265 7.00009 7.0555 7.24681 7.00787 7.56825L7.00064 7.66675V11.3334C7.00064 11.6683 7.24737 11.9453 7.56881 11.9929L7.66731 12.0001H8.25064C10.2549 12.0001 11.8919 13.5725 11.9954 15.5509L12.0006 15.7501V16.3334C12.0006 16.6683 12.2474 16.9453 12.5688 16.9929L12.6673 17.0001H16.334C16.6686 17.0001 16.9458 16.7535 16.9934 16.432L17.0006 16.3334V15.7501C17.0006 11.0039 13.2218 7.14029 8.50863 7.00382L8.25064 7.00009Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
