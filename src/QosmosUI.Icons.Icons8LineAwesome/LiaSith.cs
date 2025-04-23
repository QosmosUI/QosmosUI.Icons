// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaSith : ComponentBase
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
		builder.AddAttribute(14, "d", "M 4 4 L 7.734375 10.361328 L 5 10 L 8.2480469 14.058594 C 8.0918289 14.681542 8 15.329318 8 16 C 8 16.670682 8.0918289 17.318458 8.2480469 17.941406 L 5 22 L 7.734375 21.638672 L 4 28 L 10.361328 24.265625 L 10 27 L 14.058594 23.751953 C 14.681542 23.908171 15.329318 24 16 24 C 16.670682 24 17.318458 23.908171 17.941406 23.751953 L 22 27 L 21.638672 24.265625 L 28 28 L 24.265625 21.638672 L 27 22 L 23.751953 17.941406 C 23.908171 17.318458 24 16.670682 24 16 C 24 15.329318 23.908171 14.681542 23.751953 14.058594 L 27 10 L 24.265625 10.361328 L 28 4 L 21.638672 7.734375 L 22 5 L 17.941406 8.2480469 C 17.318458 8.0918289 16.670682 8 16 8 C 15.329318 8 14.681542 8.0918289 14.058594 8.2480469 L 10 5 L 10.361328 7.734375 L 4 4 z M 16 10 C 19.309 10 22 12.691 22 16 C 22 19.309 19.309 22 16 22 C 12.691 22 10 19.309 10 16 C 10 12.691 12.691 10 16 10 z M 16 12 A 4 4 0 0 0 16 20 A 4 4 0 0 0 16 12 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
