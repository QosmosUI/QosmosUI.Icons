// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiOrganigram : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 26.3c-19.924 0-36.076 18.7-36.076 41.768.014 17.119 9.05 32.494 22.797 38.795C223.827 117.95 206 149.828 206 172.488h100c0-22.65-17.813-54.508-36.695-65.61 13.741-6.312 22.766-21.693 22.771-38.81 0-23.067-16.152-41.767-36.076-41.767zm-9 165.212v41H61v83h18v-65h168v65h18v-65h168v65h18v-83H265v-41zm-177 148c-19.924 0-36.076 18.7-36.076 41.767.014 17.119 9.05 32.494 22.797 38.795C37.827 431.161 20 463.04 20 485.7h100c0-22.65-17.813-54.51-36.695-65.611 13.741-6.313 22.766-21.692 22.771-38.809 0-23.067-16.152-41.768-36.076-41.767zm186 0c-19.924 0-36.076 18.7-36.076 41.767.014 17.119 9.05 32.494 22.797 38.795C223.827 431.161 206 463.04 206 485.7h100c0-22.65-17.813-54.51-36.695-65.611 13.741-6.313 22.766-21.692 22.771-38.809 0-23.067-16.152-41.768-36.076-41.767zm186 0c-19.924 0-36.076 18.7-36.076 41.767.014 17.119 9.05 32.494 22.797 38.795C409.827 431.161 392 463.04 392 485.7h100c0-22.65-17.813-54.51-36.695-65.611 13.741-6.313 22.766-21.692 22.771-38.809 0-23.067-16.152-41.768-36.076-41.767z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
