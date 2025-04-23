// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPagoda : ComponentBase
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
		builder.AddAttribute(14, "d", "M255.967 23.386c19.704 15.157 49.792 21.65 82.52 27.105 21.419 3.57 43.864 6.501 65.163 9.832-7.28 1.686-14.641 3.4-21.609 4.97-21.25 4.789-41 8.38-45.967 8.321H175.8l-.168.006c-4.61.172-24.44-3.34-45.662-8.181-7.035-1.605-14.48-3.364-21.842-5.09 21.346-3.342 43.848-6.279 65.32-9.858 32.727-5.454 62.815-11.948 82.52-27.105zm55 67.228v16h-110v-16zm3.394 34a24.977 24.977 0 0 0 4.563 4.28c3.799 2.763 8.317 4.922 13.701 7.076 10.768 4.307 24.987 8.332 41.158 12.375 18.612 4.653 39.434 9.269 60.069 13.865l-50.182 8.404H128.71l-50.54-8.424c20.606-4.59 41.396-9.2 59.98-13.845 16.172-4.043 30.39-8.068 41.159-12.375 5.384-2.154 9.902-4.313 13.7-7.076a24.977 24.977 0 0 0 4.563-4.28zm28.606 62v30h-46v-30zm-64 0v30h-46v-30zm-64 0v30h-46v-30zm131.123 48c1.246 1.65 2.68 3.113 4.156 4.422 3.592 3.184 8.04 6.026 13.383 8.965 10.686 5.877 24.947 11.954 41.178 18.041 20.082 7.531 43.024 14.894 65.33 21.42l-54.914 9.152H96.263l-54.533-9.133c22.327-6.53 45.294-13.9 65.397-21.439 16.23-6.087 30.492-12.164 41.178-18.041 5.343-2.939 9.79-5.781 13.382-8.965 1.477-1.309 2.91-2.772 4.157-4.422zm28.877 80v30h-238v-30zm3.123 48c1.246 1.65 2.68 3.113 4.156 4.422 3.592 3.184 8.04 6.026 13.383 8.965 10.686 5.877 24.947 11.954 41.178 18.041 20.102 7.539 43.07 14.909 65.396 21.44l-54.533 9.132H64.71l-54.913-9.152c22.305-6.526 45.247-13.889 65.33-21.42 16.23-6.087 30.492-12.164 41.178-18.041 5.343-2.939 9.79-5.781 13.382-8.965 1.477-1.309 2.91-2.772 4.157-4.422zm60.877 80v46h-142v-46zm-160 0v46h-46v-46zm-64 0v46h-142v-46z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
