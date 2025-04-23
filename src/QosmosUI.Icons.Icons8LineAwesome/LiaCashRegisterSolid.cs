// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaCashRegisterSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 22 3 L 22 7 C 20.152344 7 18.386719 7.332031 16.734375 7.910156 L 16.207031 6.761719 L 17.109375 6.359375 L 16.296875 4.53125 L 12.644531 6.15625 L 13.457031 7.984375 L 14.378906 7.574219 L 14.890625 8.679688 C 13.796875 9.226563 12.78125 9.898438 11.847656 10.667969 L 11.0625 9.832031 L 11.789063 9.164063 L 10.4375 7.6875 L 7.492188 10.394531 L 8.84375 11.871094 L 9.585938 11.1875 L 10.390625 12.035156 C 9.433594 13.050781 8.609375 14.191406 7.945313 15.429688 L 6.863281 14.894531 L 7.3125 14.011719 L 5.53125 13.105469 L 3.71875 16.671875 L 5.5 17.578125 L 5.957031 16.675781 L 7.101563 17.246094 C 6.523438 18.738281 6.15625 20.332031 6.050781 22 L 4 22 L 4 28 L 28 28 L 28 3 Z M 24 5 L 26 5 L 26 22 L 8.050781 22 C 8.5625 14.726563 14.59375 9 22 9 L 24 9 Z M 18 11.953125 C 16.894531 11.953125 16 12.851563 16 13.953125 C 16 14.667969 16.382813 15.328125 17 15.6875 L 17 20 L 22 20 L 22 18 L 19 18 L 19 15.683594 C 19.617188 15.328125 20 14.667969 20 13.953125 C 20 12.851563 19.105469 11.953125 18 11.953125 Z M 6 24 L 26 24 L 26 26 L 6 26 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
