// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSpikesHalf : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 16c-7.5 67.5-37.5 150-37.5 180 0 15 15 30 37.5 30s37.5-15 37.5-30c0-30-30-112.5-37.5-180zM96.906 96.906c63.64 84.853 63.644 84.862 74.25 95.47 10.607 10.606 21.206 21.2 31.813 10.593 10.605-10.608.01-21.207-10.595-31.814-10.607-10.606-10.616-10.61-95.47-74.25zm318.188 0c-84.853 63.64-84.863 63.644-95.47 74.25-10.606 10.607-21.2 21.206-10.593 31.813 10.608 10.605 21.207.012 31.814-10.595 10.606-10.606 10.61-10.616 74.25-95.47zM196 218.5c-30 0-112.5 30-180 37.5 67.5 7.5 150 37.5 180 37.5 15 0 30-15 30-37.5s-15-37.5-30-37.5zm120 0c-15 0-30 15-30 37.5s15 37.5 30 37.5c30 0 112.5-30 180-37.5-67.5-7.5-150-37.5-180-37.5zM256 286c-22.5 0-37.5 15-37.5 30 0 30 30 112.5 37.5 180 7.5-67.5 37.5-150 37.5-180 0-15-15-30-37.5-30zm-62.97 18.656c-7.29.4-14.582 7.677-21.874 14.97-10.606 10.606-10.61 10.615-74.25 95.468 84.853-63.64 84.862-63.644 95.47-74.25 10.606-10.607 21.2-21.206 10.593-31.813-3.316-3.313-6.624-4.555-9.94-4.374zm124.94 0c-2.984.1-5.956 1.392-8.94 4.375-10.605 10.608-.01 21.207 10.595 31.814 10.606 10.606 10.616 10.61 95.47 74.25-63.64-84.853-63.645-84.862-74.25-95.47-7.625-7.622-15.253-15.22-22.876-14.968z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
