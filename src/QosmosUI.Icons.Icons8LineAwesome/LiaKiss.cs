// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaKiss : ComponentBase
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
		builder.AddAttribute(14, "d", "M 16 3 C 8.832 3 3 8.832 3 16 C 3 23.168 8.832 29 16 29 C 23.168 29 29 23.168 29 16 C 29 8.832 23.168 3 16 3 z M 16 5 C 22.065 5 27 9.935 27 16 C 27 22.065 22.065 27 16 27 C 9.935 27 5 22.065 5 16 C 5 9.935 9.935 5 16 5 z M 11.5 12 A 1.5 1.5 0 0 0 11.5 15 A 1.5 1.5 0 0 0 11.5 12 z M 20.5 12 A 1.5 1.5 0 0 0 20.5 15 A 1.5 1.5 0 0 0 20.5 12 z M 15 17.007812 L 15 18.498047 C 15.901 18.498047 16.476562 18.912906 16.476562 19.128906 C 16.476562 19.344035 15.90451 19.754497 15.009766 19.757812 C 15.006431 19.757805 15.003337 19.757812 15 19.757812 L 15 19.759766 L 15 21.248047 L 15 21.25 C 15.003337 21.25 15.006431 21.250007 15.009766 21.25 C 15.90451 21.253316 16.476562 21.663777 16.476562 21.878906 C 16.476562 22.094906 15.901 22.509766 15 22.509766 L 15 24 C 16.669 24 17.976562 23.067906 17.976562 21.878906 C 17.976562 21.346428 17.703054 20.872671 17.263672 20.503906 C 17.703054 20.135141 17.976562 19.661385 17.976562 19.128906 C 17.976562 17.939906 16.669 17.007812 15 17.007812 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
