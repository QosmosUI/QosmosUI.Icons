// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiWalkieTalkie : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M71 32v135h18V32H71zm256 0v135h18V32h-18zm-208 95.604V167h18v-39.396h-18zm256 0V167h18v-39.396h-18zM57 185v99.27l16 16V487h110V300.27l16-16V185H57zm256 0v99.27l16 16V487h110V300.27l16-16V185H313zm-96 7v80h16.432v-80H217zm256 0v80h16.432v-80H473zm-393 7h96v18H80v-18zm256 0h96v18h-96v-18zM80 231h96v18H80v-18zm256 0h96v18h-96v-18zM80 263h96v18H80v-18zm256 0h96v18h-96v-18zm-224 41a24 24 0 0 1 24 24 24 24 0 0 1-24 24 24 24 0 0 1-24-24 24 24 0 0 1 24-24zm256 0a24 24 0 0 1 24 24 24 24 0 0 1-24 24 24 24 0 0 1-24-24 24 24 0 0 1 24-24z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
