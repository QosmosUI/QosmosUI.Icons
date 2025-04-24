// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiGitPullRequest : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
		builder.AddAttribute(14, "d", "M9.169 5.186c-1.885 0-3.415 1.53-3.415 3.415 0 1.26 0.691 2.35 1.708 2.943v11.192c-1.016 0.592-1.708 1.681-1.708 2.942 0 1.884 1.53 3.415 3.415 3.415s3.415-1.531 3.415-3.415c0-1.261-0.69-2.35-1.708-2.942v-11.192c1.018-0.593 1.708-1.683 1.708-2.943-0-1.885-1.53-3.415-3.415-3.415zM9.169 27.385c-0.942 0-1.708-0.764-1.708-1.708 0-0.942 0.765-1.708 1.708-1.708 0.945 0 1.708 0.765 1.708 1.708 0 0.944-0.763 1.708-1.708 1.708zM9.169 10.309c-0.942 0-1.708-0.763-1.708-1.708s0.765-1.708 1.708-1.708c0.945 0 1.708 0.763 1.708 1.708s-0.763 1.708-1.708 1.708zM24.538 22.736v-10.72c0-5.136-5.123-5.123-5.123-5.123h-1.708v-3.415l-5.123 5.123 5.123 5.123v-3.415c0 0 0.712 0 1.708 0 1.506 0 1.708 1.708 1.708 1.708v10.719c-1.017 0.592-1.708 1.679-1.708 2.942 0 1.884 1.531 3.415 3.415 3.415s3.415-1.531 3.415-3.415c0-1.261-0.691-2.35-1.708-2.942zM22.831 27.385c-0.942 0-1.708-0.764-1.708-1.708 0-0.942 0.765-1.708 1.708-1.708 0.944 0 1.708 0.765 1.708 1.708 0 0.944-0.764 1.708-1.708 1.708z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
