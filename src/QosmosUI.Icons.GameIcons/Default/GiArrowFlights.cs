// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiArrowFlights : ComponentBase
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
		builder.AddAttribute(14, "d", "M182.938 17.75l-29.625 112-64.22-64.313-18.218 18.22L480.78 494.124h11.814V469.5L264.72 241.28l29.624-112.124-17.53-17.53-16.783 37.468-.31-54.563-23.564-23.56-12.125 19.75-2.343-34.22-38.75-38.75zM419.875 81l-17.563 66.47-35.406-35.407-14.875 15.156 140.564 140.593V237.75l-20.375-20.375 17.592-66.438L419.875 81zM114.72 154l-92.814 24.53 16.75 16.75 50.97-1-37.19 14.782 39.44 39.438 32.905 2.03-12.874 8.907 20.688 1.282-16.844 11.655 17.594 17.594L226 265.436 114.72 154zm252.936 15.28l-48.97 12.94 25.658 25.655 31.875 2.156-18.408 11.314 30.782 30.78 48.97-12.936-69.908-69.907zM122.78 316.313l-17.56 66.407-35.345-35.47-15.313 15.313 131.594 131.562h30.094l-41.156-41.313 17.594-66.593-13.907-13.908-12.093 19.782-2.343-34.22-41.563-41.562zm188.907 51.594l-10.843 41.063-23.5-23.5-13.22 13.217 23.376 23.344-40.72 10.783 44.814 44.812 40.72-10.78 27.998 28h26.407l-41.095-41.095 10.844-41.03-19.158-19.19-8.562 7.75-3.344-19.624-13.72-13.75zM70.25 404.656L21.562 417.5l54 54h34.094L93.126 487l47.03-12.438-69.906-69.906z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
