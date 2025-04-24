// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiAirchina : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M6.75 23.377c3.431.96 7.361-1.449 7.361-5.442v-4.713c0-1.377 1.147-3.19 3.212-3.19 2.17 0 3.201 1.949 3.201 3.19 0 .792-.313 2.377-1.804 2.377-1.188 0-1.95-1.21-1.574-2.2-.083.333.093.657.449.657.343 0 .532-.324.468-.73 0-.083-.104-.834-.939-.834-.698 0-.927.636-.927.948v4.193c0 4.483-4.88 7.798-9.447 5.744M3.508 19.99s2.303 2.336 5.338.573c2.012-1.167 2.075-3.598 2.075-3.598v-5.431s-.084-2.722 2.366-4.672c1.711-1.345 3.296-1.252 4.39-1.387 2.806-.344 4.057-2.116 4.057-2.116.031.302-.272 3.555-3.785 4.483-.72.188-4.578-.187-4.578 4.275v5.38c0 1.126-.27 3.118-2.377 4.526-2.169 1.439-5.683 1.21-7.486-2.033M1.047 8.759H3.85c0-.5.428-1.471 1.523-1.471.427 0 .5.095 1.052-.02.72-.24 1.043-.657 1.19-.99 0 0 .28 1.187-.845 1.813-.637.345-1.616.074-1.616.074s-.792-.115-.897.593c.449 0 1.147.449 1.147 1.22v6.528c0 .469.375.96.949.96a.95.95 0 0 0 .949-.96v-4.578c0-6.757 5.255-9.56 8.31-9.79 2.533-.188 4.244.04 7.34-2.138 0 0-.97 3.796-5.358 4.703-.804.166-3.224-.115-5.497 2.252-1.803 1.877-1.99 3.608-1.99 5.891v4.035c0 1.762-1.419 3.545-3.587 3.545-2.096 0-3.566-1.668-3.566-3.545v-6.85c0-.563-.406-1.074-1.054-1.074h-.854Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
