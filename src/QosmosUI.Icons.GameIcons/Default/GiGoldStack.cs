// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiGoldStack : ComponentBase
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
		builder.AddAttribute(14, "d", "M313.824 61.625l-67.865 118.24L176 96l-4.08 129.77L56.162 105.264 112 272l-81.986-63.115 19.865 113.77L18 311.724V391h7.514l16-48h40l16-48h40l16-48h40l16-48h92.972l16 48h40l16 48h40l16 48h40l16 48H494V241.285l-77.783 39.547L480 144l-125.797 83.758L400 128l-74.926 66.87zM222.486 217l-10 30h87.028l-10-30zm-56 48l-10 30h87.028l-10-30zm86 0L256 275.54l3.514-10.54zm26 0l-10 30h87.028l-10-30zm-168 48l-10 30h87.028l-10-30zm86 0L200 323.54l3.514-10.54zm26 0l-10 30h87.028l-10-30zm86 0L312 323.54l3.514-10.54zm26 0l-10 30h87.028l-10-30zm-280 48l-10 30h87.028l-10-30zm86 0L144 371.54l3.514-10.54zm26 0l-10 30h87.028l-10-30zm86 0L256 371.54l3.514-10.54zm26 0l-10 30h87.028l-10-30zm86 0L368 371.54l3.514-10.54zm26 0l-10 30h87.028l-10-30zM18 409v30h57.514l-10-30zm66.486 0L88 419.54 91.514 409zm26 0l-10 30h87.028l-10-30zm86 0L200 419.54l3.514-10.54zm26 0l-10 30h87.028l-10-30zm86 0L312 419.54l3.514-10.54zm26 0l-10 30h87.028l-10-30zm86 0L424 419.54l3.514-10.54zm26 0l-10 30H494v-30zm-418 48L32 467.54 35.514 457zm26 0l-10 30h87.028l-10-30zm86 0L144 467.54l3.514-10.54zm26 0l-10 30h87.028l-10-30zm86 0L256 467.54l3.514-10.54zm26 0l-10 30h87.028l-10-30zm86 0l3.344 10.033.342-.01L371.514 457zm26 0l-10 30h87.028l-10-30zm86 0l2.287 6.863 2.477-.07 2.264-6.793z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
