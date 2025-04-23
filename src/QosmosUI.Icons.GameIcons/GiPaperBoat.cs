// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPaperBoat : ComponentBase
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
		builder.AddAttribute(14, "d", "M247 40l-74.6 161.6 74.6 24.9V40zm18 0v186.5l74.6-24.9L265 40zm-86.7 105.8l-136.02 17 112.02 35 24-52zm155.4 0l24 52 112.1-35-136.1-17zM25.48 176.4L130 307.1l104.6-65.4-209.12-65.3zm461.02 0l-209.1 65.3L382 307.1l104.5-130.7zM256 249.6L159.4 310h193.2L256 249.6zM128 358c-16 0-32.14 9-45.68 17.3-13.53 8.4-23.93 16.7-23.93 16.7l11.22 14s9.65-7.7 22.14-15.3C104.2 383 120.1 376 128 376c7.9 0 16.4 6 26.4 14s21.6 18 37.6 18 27.6-10 37.6-18 18.5-14 26.4-14c7.9 0 16.4 6 26.4 14s21.6 18 37.6 18 27.6-10 37.6-18 18.5-14 26.4-14c7.9 0 23.8 7 36.2 14.7 12.5 7.6 22.2 15.3 22.2 15.3l11.2-14s-10.4-8.3-23.9-16.7C416.1 367 400 358 384 358c-16 0-27.6 10-37.6 18s-18.5 14-26.4 14c-7.9 0-16.4-6-26.4-14S272 358 256 358s-27.6 10-37.6 18-18.5 14-26.4 14c-7.9 0-16.4-6-26.4-14S144 358 128 358zm0 64c-16 0-32.14 9-45.68 17.3-13.53 8.4-23.93 16.7-23.93 16.7l11.22 14s9.65-7.7 22.14-15.3C104.2 447 120.1 440 128 440c7.9 0 16.4 6 26.4 14s21.6 18 37.6 18 27.6-10 37.6-18 18.5-14 26.4-14c7.9 0 16.4 6 26.4 14s21.6 18 37.6 18 27.6-10 37.6-18 18.5-14 26.4-14c7.9 0 23.8 7 36.2 14.7 12.5 7.6 22.2 15.3 22.2 15.3l11.2-14s-10.4-8.3-23.9-16.7C416.1 431 400 422 384 422c-16 0-27.6 10-37.6 18s-18.5 14-26.4 14c-7.9 0-16.4-6-26.4-14S272 422 256 422s-27.6 10-37.6 18-18.5 14-26.4 14c-7.9 0-16.4-6-26.4-14S144 422 128 422z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
