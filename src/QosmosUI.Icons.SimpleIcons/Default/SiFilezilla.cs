// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiFilezilla : ComponentBase
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
		builder.AddAttribute(15, "d", "M23.999 1.861V.803a.81.81 0 0 1-.568-.236.81.81 0 0 1-.234-.567h-1.06a.806.806 0 0 1-1.608 0h-1.06a.805.805 0 0 1-1.608 0h-1.059a.807.807 0 0 1-.845.765.808.808 0 0 1-.764-.765h-1.06a.806.806 0 0 1-1.609 0h-1.058a.805.805 0 0 1-1.608 0h-1.06a.794.794 0 0 1-.825.774A.803.803 0 0 1 7.197 0h-1.06A.806.806 0 0 1 4.53 0H3.47a.803.803 0 0 1-1.607 0H.803a.806.806 0 0 1-.802.803V1.86a.804.804 0 0 1 0 1.607v1.06a.803.803 0 0 1 0 1.607v1.059a.805.805 0 0 1 0 1.608v1.06a.803.803 0 1 1 0 1.607v1.06a.803.803 0 0 1 0 1.606v1.06a.803.803 0 1 1 0 1.608v1.06c.444.017.79.388.774.83a.801.801 0 0 1-.774.775v1.061a.803.803 0 1 1 0 1.608v1.06A.805.805 0 0 1 .804 24h1.06a.806.806 0 0 1 1.607 0h1.06a.806.806 0 0 1 1.608 0h1.059a.806.806 0 0 1 1.609 0h1.06a.804.804 0 0 1 1.607 0h1.06a.806.806 0 0 1 1.607 0H15.2a.807.807 0 0 1 1.61 0h1.058a.807.807 0 0 1 1.61 0h1.059a.804.804 0 0 1 1.606 0h1.054c0-.21.086-.418.235-.568a.808.808 0 0 1 .567-.234v-1.06a.805.805 0 0 1 0-1.606v-1.06a.805.805 0 0 1 0-1.608v-1.06a.806.806 0 0 1 0-1.608v-1.061a.804.804 0 0 1 0-1.608V11.47a.806.806 0 0 1 0-1.608v-1.06a.804.804 0 0 1 0-1.607v-1.06a.805.805 0 0 1 0-1.606v-1.06a.806.806 0 0 1 0-1.608zm-4.067 9.836L13.53 17.92c.58.09 1.14.225 1.742.225 1.464 0 3.147-.445 4.285-.916l-.584 2.745c-1.675.805-2.7.87-3.701.87-1.095 0-2.144-.356-3.215-.356-.602 0-1.473.045-2.008.4l-1.16-2.052 6.604-6.54h-7.6l-1.45 6.806h-3.17L6.577 3.528h10.487l-.67 3.145H9.097l-.624 2.924h11.973z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
