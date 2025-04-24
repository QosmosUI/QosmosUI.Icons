// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscHeartFilled : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M14.88 4.78079C14.7993 4.46498 14.6748 4.16202 14.51 3.88077C14.3518 3.58819 14.1493 3.3217 13.91 3.09073C13.563 2.74486 13.152 2.46982 12.7 2.28079C11.7902 1.90738 10.7698 1.90738 9.85999 2.28079C9.43276 2.46163 9.04027 2.71541 8.70002 3.03079L8.65003 3.09073L8.00001 3.74075L7.34999 3.09073L7.3 3.03079C6.95975 2.71541 6.56726 2.46163 6.14002 2.28079C5.23018 1.90738 4.20984 1.90738 3.3 2.28079C2.84798 2.46982 2.43706 2.74486 2.09004 3.09073C1.85051 3.32402 1.64514 3.59002 1.48002 3.88077C1.32258 4.1644 1.20161 4.46682 1.12 4.78079C1.03522 5.10721 0.994861 5.44358 1.00001 5.78079C1.00053 6.09791 1.04084 6.41365 1.12 6.72073C1.20384 7.03078 1.32472 7.32961 1.48002 7.61075C1.64774 7.89975 1.85285 8.16542 2.09004 8.40079L8.00001 14.3108L13.91 8.40079C14.1471 8.16782 14.3492 7.90169 14.51 7.61075C14.6729 7.33211 14.7974 7.03272 14.88 6.72073C14.9592 6.41365 14.9995 6.09791 15 5.78079C15.0052 5.44358 14.9648 5.10721 14.88 4.78079Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
