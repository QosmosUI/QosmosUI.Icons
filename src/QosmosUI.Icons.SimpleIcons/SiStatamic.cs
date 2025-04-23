// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiStatamic : ComponentBase
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
		builder.AddAttribute(15, "d", "M19.78 21.639c1.754 0 2.398-.756 2.398-2.607v-3.62c0-1.722.837-2.704 1.641-3.17.242-.145.242-.483 0-.644-.836-.531-1.64-1.642-1.64-3.122v-3.54c0-1.996-.548-2.575-2.302-2.575H4.123c-1.754 0-2.301.58-2.301 2.575v3.556c0 1.48-.805 2.59-1.641 3.122a.377.377 0 0 0 0 .643c.804.451 1.64 1.433 1.64 3.17v3.605c0 1.85.645 2.607 2.399 2.607zm-7.82-3.299c-1.883 0-3.25-.563-4.522-1.673a.891.891 0 0 1-.29-.676.83.83 0 0 1 .193-.563l.403-.515c.193-.242.402-.354.643-.354.274 0 .531.112.805.29a5.331 5.331 0 0 0 2.993.884c.885 0 1.593-.37 1.593-1.126 0-1.963-6.533-.885-6.533-5.294 0-2.366 1.93-3.685 4.441-3.685 1.77 0 3.074.515 4.04 1.126.24.161.402.483.402.805 0 .193-.049.37-.161.53l-.29.435c-.21.29-.45.435-.756.435-.21 0-.435-.08-.676-.193a5.07 5.07 0 0 0-2.398-.564c-.95 0-1.513.515-1.513 1.046 0 2.012 6.534.918 6.534 5.198 0 2.414-1.947 3.894-4.908 3.894z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
