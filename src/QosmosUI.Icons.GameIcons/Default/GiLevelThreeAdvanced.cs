// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiLevelThreeAdvanced : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 46c-27.713 84-55.438 84-55.438 140 0 0 27.725 28 55.438 28 27.712 0 55.438-28 55.438-28 0-56-27.726-56-55.438-140zm0 168c-61.22 0-110.844 50.143-110.844 112 0 20.287 5.353 39.307 14.688 55.72-13.986-24.05-51.563-34.22-51.563-34.22-48 28-34.137 52.25-92.28 118.5 85.856-17.75 99.72 6.5 147.72-21.5 0 0 10.076-38.055-3.626-62.313C179.287 415.56 215.047 438 256 438s76.713-22.44 95.906-55.813c-13.7 24.258-3.625 62.313-3.625 62.313 48 28 61.863 3.75 147.72 21.5-58.144-66.25-44.28-90.5-92.28-118.5 0 0-37.577 10.17-51.564 34.22 9.335-16.413 14.688-35.433 14.688-55.72 0-61.856-49.623-112-110.844-112zm-27.72 28h55.44v56h55.405v56H283.72v56h-55.44v-56h-55.405v-56h55.406v-56z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
