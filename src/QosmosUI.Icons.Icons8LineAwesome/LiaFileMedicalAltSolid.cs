// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaFileMedicalAltSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 6 3 L 6 14 L 7.3671875 14 L 8 12.419922 L 8 5 L 18 5 L 18 11 L 24 11 L 24 27 L 8 27 L 8 21.246094 L 7.9472656 21.193359 L 6.7558594 20 L 6 20 L 6 29 L 26 29 L 26 9.59375 L 25.71875 9.28125 L 19.71875 3.28125 L 19.40625 3 L 6 3 z M 20 6.4375 L 22.5625 9 L 20 9 L 20 6.4375 z M 10.96875 10.386719 L 8.6328125 16.21875 L 8.4140625 16 L 2 16 L 2 18 L 7.5859375 18 L 9.3632812 19.78125 L 11.03125 15.613281 L 14.03125 22.613281 L 16.101562 17.4375 L 16.382812 18 L 18.269531 18 C 18.628531 18.617 19.286 19 20 19 C 21.105 19 22 18.105 22 17 C 22 15.895 21.105 15 20 15 C 19.285 15 18.624531 15.383 18.269531 16 L 17.617188 16 L 15.898438 12.5625 L 13.96875 17.386719 L 10.96875 10.386719 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
