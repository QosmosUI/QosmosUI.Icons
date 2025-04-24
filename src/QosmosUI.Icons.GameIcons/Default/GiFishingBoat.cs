// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFishingBoat : ComponentBase
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
		builder.AddAttribute(14, "d", "M232.54 67.154l-17.08 5.692L241.513 151h18.976zM71.28 106.707l-14.56 10.586L71 136.928V230h18v-68.322L161.234 261h22.258zM272 117v18h39v16h18v-16h39v-18zm-23 52v126h108.943l-5.111-46H279v-80zm48 0v62h53.834l-6.889-62zM89 279v16h110v-16zm-70.012 34l41.248 110h319.68l114.25-110H140.588C157.022 318.35 169 333.85 169 352c0 22.537-18.463 41-41 41s-41-18.463-41-41c0-18.15 11.978-33.65 28.412-39zM128 329c-12.81 0-23 10.19-23 23s10.19 23 23 23 23-10.19 23-23-10.19-23-23-23zm208 0h80v18h-80zM96 439c-28.777 2.338-51.11 8.201-78.61 16.387l5.22 17.226C45.822 467.213 71.59 457.287 96 457c23.665 0 49.275 16 80 16s56.335-16 80-16 49.275 16 80 16 56.335-16 80-16c27.734 2.18 46.87 7.726 73.39 15.613l5.22-17.226C468.536 448.762 443.471 439.273 416 439c-30.725 0-56.335 16-80 16s-49.275-16-80-16-56.335 16-80 16-49.275-16-80-16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
