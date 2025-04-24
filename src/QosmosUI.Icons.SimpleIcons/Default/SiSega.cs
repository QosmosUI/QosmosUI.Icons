// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiSega : ComponentBase
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
		builder.AddAttribute(15, "d", "M21.229 4.14l-.006 3.33h-10.6c-.219 0-.397.181-.397.399 0 .221.18.399.397.399l2.76-.016c4.346 0 7.868 3.525 7.868 7.869 0 4.348-3.522 7.869-7.869 7.869L2.748 24l.005-3.375h10.635c2.487 0 4.504-2.016 4.504-4.504 0-2.49-2.017-4.506-4.506-4.506l-2.771-.03c-2.06 0-3.727-1.666-3.727-3.72 0-2.061 1.666-3.726 3.723-3.726h10.618zM2.763 19.843l-.004-3.331h10.609c.21 0 .383-.175.383-.387 0-.213-.173-.385-.384-.385h-2.744c-4.345 0-7.867-3.525-7.867-7.871S6.278 0 10.623 0l10.6.003.006 3.35-10.604.003c-2.49 0-4.5 2.019-4.5 4.507 0 2.489 2.024 4.504 4.515 4.504l2.775.03c2.055 0 3.72 1.668 3.72 3.724 0 2.055-1.665 3.719-3.72 3.719H2.765l-.002.003z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
