// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaLevelDownAltSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 4.5 4.5 L 4.5 5 L 4.5 7.5 L 19.5 7.5 L 19.5 22.855469 L 15.71875 19.074219 L 13.574219 21.21875 L 19.931641 27.576172 L 21 28.597656 L 22.068359 27.576172 L 28.425781 21.21875 L 26.28125 19.074219 L 22.5 22.855469 L 22.5 6 L 22.5 4.5 L 21 4.5 L 4.5 4.5 z M 5.5 5.5 L 21 5.5 L 21.5 5.5 L 21.5 6 L 21.5 25.269531 L 26.28125 20.488281 L 27.011719 21.21875 L 21.369141 26.861328 L 21 27.214844 L 20.630859 26.861328 L 14.988281 21.21875 L 15.71875 20.488281 L 20.5 25.269531 L 20.5 6.5 L 5.5 6.5 L 5.5 5.5 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
